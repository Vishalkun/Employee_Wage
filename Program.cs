namespace PractisePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random R=new Random();  
            int empcheck= new Random().Next(0,2);
            if(empcheck== IS_FULL_TIME)
            {
                Console.WriteLine(" Employee is Present");
            }
            else
            {
                Console.WriteLine("Employe is not present");
            }
        }
    }
}