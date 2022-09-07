public class TradeProcessor
{
    private List<string> GetLinesFromCsvStream(System.IO.Stream stream)
    {
        // read rows
        var lines = new List<string>();
        using(var reader = new System.IO.StreamReader(stream))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }
        return lines;
    }
    
    private List<TradeRecord> ValidateLines(List<string> lines){
           var trades = new List<TradeRecord>();

        var lineCount = 1;
        foreach(var line in lines)
        {
            var fields = line.Split(new char[] { ',' });

            if(fields.Length != 3)
            {
                WriteToConsole(String.Format("WARN: Line {0} malformed. Only {1} field(s) found.",lineCount, fields.Length));
                continue;
            }

            if(fields[0].Length != 6)
            {
                WriteToConsole(String.Format("WARN: Trade currencies on line {0} malformed: '{1}'",lineCount, fields[0]));
                continue;
            }

            int tradeAmount;
            if(!int.TryParse(fields[1], out tradeAmount))
            {
                WriteToConsole(String.Format("WARN: Trade amount on line {0} not a valid integer:'{1}'", lineCount, fields[1]));
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                WriteToConsole(String.Format("WARN: Trade price on line {0} not a valid decimal:'{1}'", lineCount, fields[2]));
            }

            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);

            // calculate values
            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };

            trades.Add(trade);

            lineCount++;
        }

    }
    public void SaveToDataBase( List<TradeRecord> trades){
      using (var connection = new System.Data.SqlClient.SqlConnection("Data
  Source=(local);Initial Catalog=TradeDatabase;Integrated Security=True"))
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                foreach(var trade in trades)
                {
                    var command = connection.CreateCommand();
                    command.Transaction = transaction;
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.insert_trade";
                    command.Parameters.AddWithValue("@sourceCurrency", trade.SourceCurrency);
                    command.Parameters.AddWithValue("@destinationCurrency", trade.DestinationCurrency);
                    command.Parameters.AddWithValue("@lots", trade.Lots);
                    command.Parameters.AddWithValue("@price", trade.Price);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            connection.Close();
        }

        WriteToConsole(strng.Format("INFO: {0} trades processed", trades.Count));   
    }
    private void WriteToConsole(string message){
           Console.WriteLine(message);
    }
    public void ProcessTrades(System.IO.Stream stream)
    {
       List<string> lines= GetLinesFromCsvStream(stream);
        List<TradeRecord> trades=ValidateLines(lines);
       SaveToDataBase(trades);   
        

     
       
    }

    private static float LotSize = 100000f;
}




class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }
