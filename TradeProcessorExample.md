```C#
public class ConsoleLogger
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class TradeDataSqlPersister
    {
        ConsoleLogger logger;
        public TradeDataSqlPersister(ConsoleLogger logger)
        {
            this.logger = logger;
        }
        public void Persist(List<TradeRecord> trades)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source = (local); Initial Catalog = TradeDatabase; Integrated Security = True"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var trade in trades)
                    {
                        var command = connection.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "dbo.insert_trade";
                        command.Parameters.AddWithValue("@sourceCurrency", trade.
      SourceCurrency);
                        command.Parameters.AddWithValue("@destinationCurrency", trade.
      DestinationCurrency);
                        command.Parameters.AddWithValue("@lots", trade.Lots);
                        command.Parameters.AddWithValue("@price", trade.Price);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                connection.Close();
            }
            logger.Write(string.Format("INFO: {0} trades processed", trades.Count));


        }
    }

    public class CSVTradeDataReader
    {
        System.IO.Stream _stream;
        private readonly float LotSize = 100000F;
        CSVLineValidator _validator;
        public CSVTradeDataReader(System.IO.Stream  source,CSVLineValidator validator)
        {
            this._stream = source;
            this._validator = validator;
        }
        public List<TradeRecord> GetTradeRecords()
        {
            var lines = new List<string>();
            using (var reader = new System.IO.StreamReader(this._stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in lines)
            {

                if (this._validator.IsValid(line,lineCount))
                {
                    var fields = line.Split(new char[] { ',' });
                    // calculate values
                    var trade = new TradeRecord
                    {
                        SourceCurrency = GetCurrencyCode(fields[0]),
                        DestinationCurrency = GetCurrencyCode(fields[0]),
                        Lots = Convert.ToInt32(fields[2]) / LotSize,
                        Price = Convert.ToDecimal(fields[3])
                    };

                    trades.Add(trade);

                    lineCount++;
                }
            }
            return trades;


        }
        public string GetCurrencyCode(string code)
        {
            return code.Substring(0, 3);

        }

    }

    public class CSVLineValidator
    {
        ConsoleLogger logger;
        public CSVLineValidator(ConsoleLogger logger)
        {
            this.logger = logger;
        }
        public bool IsValid(string line,int lineCount)
        {
            bool isValid = false;
            var fields = line.Split(new char[] { ',' });

            if (fields.Length != 3)
            {
                logger.Write($"WARN: Line {lineCount} malformed. Only {fields.Length} field(s) found.");
               
            }

            if (fields[0].Length != 6)
            {
                logger.Write( string.Format("WARN: Trade currencies on line {0} malformed: '{1}'", lineCount, fields[0]));
               
            }
            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                logger.Write(string.Format("WARN: Trade amount on line {0} not a valid integer:'{1}'", lineCount, fields[1]));
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                logger.Write( string.Format( "WARN: Trade price on line {0} not a valid decimal:'{1}'", lineCount, fields[2]));
            }

            return isValid;
           

        }
    }
    public class TradeProcessor
    {
        CSVTradeDataReader dataReader;
        TradeDataSqlPersister persister;

        public TradeProcessor(CSVTradeDataReader reader,TradeDataSqlPersister persister)
        {
            this.dataReader = reader;
            this.persister = persister;
        }
        public void ProcessTrades()
        {
            // read rows
            List<TradeRecord> records = GetAllTradeRecords();
            PersistTradeRecords(records);
         }
        public List<TradeRecord> GetAllTradeRecords()
        {
            return this.dataReader.GetTradeRecords();
        }
        public void PersistTradeRecords(List<TradeRecord> records)
        {
            this.persister.Persist(records);
        }

    }




   public  class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger _consoleLogger = new ConsoleLogger();
            CSVTradeDataReader _reader = new CSVTradeDataReader
                (System.IO.File.OpenRead("..//..//test.txt"),
                new CSVLineValidator(_consoleLogger));
            TradeDataSqlPersister _perister = new TradeDataSqlPersister(_consoleLogger);
            TradeProcessor _processor = new TradeProcessor(_reader, _perister);
        }
    }

```

#### After Abstraction

```C#

    public interface ILogger
    {
        void Write(string msg);
    }

    public class ConsoleLogger : ILogger
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public interface ITradeDataPersister
    {
        void Persist(List<TradeRecord> trades);
    }

    public class TradeDataSqlPersister : ITradeDataPersister
    {
        ILogger logger;
        public TradeDataSqlPersister(ILogger logger)
        {
            this.logger = logger;
        }
        public void Persist(List<TradeRecord> trades)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Data Source = (local); Initial Catalog = TradeDatabase; Integrated Security = True"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var trade in trades)
                    {
                        var command = connection.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "dbo.insert_trade";
                        command.Parameters.AddWithValue("@sourceCurrency", trade.
      SourceCurrency);
                        command.Parameters.AddWithValue("@destinationCurrency", trade.
      DestinationCurrency);
                        command.Parameters.AddWithValue("@lots", trade.Lots);
                        command.Parameters.AddWithValue("@price", trade.Price);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                connection.Close();
            }
            logger.Write(string.Format("INFO: {0} trades processed", trades.Count));


        }
    }

    public interface ITradeDataReader
    {
        
        List<TradeRecord> GetTradeRecords();
    }

    public class CSVTradeDataReader : ITradeDataReader
    {
        System.IO.Stream _stream;
        private readonly float LotSize = 100000F;
        CSVLineValidator _validator;
        public CSVTradeDataReader(System.IO.Stream source, CSVLineValidator validator)
        {
            this._stream = source;
            this._validator = validator;
        }
        public List<TradeRecord> GetTradeRecords()
        {
            var lines = new List<string>();
            using (var reader = new System.IO.StreamReader(this._stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in lines)
            {

                if (this._validator.IsValid(line, lineCount))
                {
                    var fields = line.Split(new char[] { ',' });
                    // calculate values
                    var trade = new TradeRecord
                    {
                        SourceCurrency = GetCurrencyCode(fields[0]),
                        DestinationCurrency = GetCurrencyCode(fields[0]),
                        Lots = Convert.ToInt32(fields[2]) / LotSize,
                        Price = Convert.ToDecimal(fields[3])
                    };

                    trades.Add(trade);

                    lineCount++;
                }
            }
            return trades;


        }
        public string GetCurrencyCode(string code)
        {
            return code.Substring(0, 3);

        }

    }

    public class CSVLineValidator
    {
        ILogger logger;
        public CSVLineValidator(ILogger logger)
        {
            this.logger = logger;
        }
        public bool IsValid(string line,int lineCount)
        {
            bool isValid = false;
            var fields = line.Split(new char[] { ',' });

            if (fields.Length != 3)
            {
                logger.Write($"WARN: Line {lineCount} malformed. Only {fields.Length} field(s) found.");
               
            }

            if (fields[0].Length != 6)
            {
                logger.Write( string.Format("WARN: Trade currencies on line {0} malformed: '{1}'", lineCount, fields[0]));
               
            }
            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                logger.Write(string.Format("WARN: Trade amount on line {0} not a valid integer:'{1}'", lineCount, fields[1]));
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                logger.Write( string.Format( "WARN: Trade price on line {0} not a valid decimal:'{1}'", lineCount, fields[2]));
            }

            return isValid;
           

        }
    }
    public class TradeProcessor
    {
        ITradeDataReader dataReader;
        ITradeDataPersister persister;

        public TradeProcessor(ITradeDataReader reader, ITradeDataPersister persister)
        {
            this.dataReader = reader;
            this.persister = persister;
        }
        public void ProcessTrades()
        {
            // read rows
            List<TradeRecord> records = GetAllTradeRecords();
            PersistTradeRecords(records);
         }
        public List<TradeRecord> GetAllTradeRecords()
        {
            return this.dataReader.GetTradeRecords();
        }
        public void PersistTradeRecords(List<TradeRecord> records)
        {
            this.persister.Persist(records);
        }

    }




   public  class TradeRecord
    {
        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public float Lots { get; set; }

        public decimal Price { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ILogger _consoleLogger = new ConsoleLogger();
            ITradeDataReader _reader = new CSVTradeDataReader
                (System.IO.File.OpenRead("..//..//test.txt"),
                new CSVLineValidator(_consoleLogger));
            ITradeDataPersister _perister = new TradeDataSqlPersister(_consoleLogger);
            TradeProcessor _processor = new TradeProcessor(_reader, _perister);
        }
    }

```

