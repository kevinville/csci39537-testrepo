using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Collections;


    interface KrustyKrab
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }
        string? WorkerData { get; }
        int Salary { get; set; }
        void returninfo();
    }

    class Spongebob : KrustyKrab
    {

        ArrayList workerInfo = new ArrayList();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string WorkerData
        {
           get{ return "First Name: " + FirstName + " Last Name: " + LastName + " Total Pay: " + Salary; }
        }

        public void returninfo()
        {
            Console.WriteLine(WorkerData);
        }

        public KrustyKrab this[int index]
        {
            get => (KrustyKrab)workerInfo[index];
            set => workerInfo.Insert(index, value);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Spongebob workerInfo = new Spongebob();
            workerInfo[0] = new Spongebob();
            workerInfo[0].FirstName = "Squidward";
            workerInfo[0].LastName = "Tentacles";
            workerInfo[0].Salary = 31513;

            workerInfo[1] = new Spongebob();
            workerInfo[1].FirstName = "SPongebob";
            workerInfo[1].LastName = "Squarepants";
            workerInfo[0].Salary = 46246;

            workerInfo[2] = new Spongebob();
            workerInfo[2].FirstName = "Eugene";
            workerInfo[2].LastName = "Krabs";
            workerInfo[0].Salary = 42624;

            for (int i = 0; i < 3; i++)
            {
                workerInfo[i].returninfo();
            }

        }
    }
