namespace ConsoleApp16.BehavioralProblem
{
    public class Person
    {

        public void Anger() { }
        public void Humor() { }
        public void Love() { }
        public void Disgust() { }
        public void Courgae() { }

        public void Calm() { }
        public void Professional() { }
    }

    public class FamilyContext
    {
        public void Connect(Person familyMmeber)
        {
            familyMmeber.Professional();//hide
            familyMmeber.Disgust();//hide
           
        }
    }
    public class FriendContext
    {
        public void Connect(Person friend)
        {
            friend.Professional();//hide
            
        }
    }
    public class SocialContext
    {
        public void Connect(Person citizen)
        {
            citizen.Anger();//hide
            citizen.Disgust();//hide
        }
    }

    public class OfficeContext
    {
        public void Connect(Person employee)
        {
            employee.Anger();//hide
        }
    }

    public class Program
    {
        public static void Main()
        {
            Person _person = new Person();
            
            FamilyContext familyContext = new FamilyContext();
            familyContext.Connect(_person);

            FriendContext friendContext = new FriendContext();
            friendContext.Connect(_person);

            OfficeContext officeContext = new OfficeContext();
            officeContext.Connect(_person);

            SocialContext socialContext = new SocialContext();
            socialContext.Connect(_person);
        }
    }
}
