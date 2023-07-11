using System;

namespace modul10
{

    abstract class Worker
    {
        protected Worker(string firstName, string lastName, string passport, string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.passport = passport;
            ChangeInformer = new ChangeInformer();
        }
        protected string firstName;

        protected string lastName;
        public string GetFirstlName()
        {
            return $"Имя: {firstName}";
        }

        public string GetLastlName()
        {
            return $"Фамилия: {lastName}";
        }


        protected string phoneNumber;
        public abstract void SetPhoneNumber(string phoneNumber);
        public string GetPhoneNumber()
        {
            return $"Телефон: {phoneNumber}";
        }



        protected string passport;
        public abstract string GetPassport(bool isHidden);




        protected ChangeInformer ChangeInformer { get; set; }
        protected void SaveChange(WorkerPosition workerPosition, string changeData, string newData)
        {
            ChangeInformer.SaveChange(workerPosition, changeData, newData);
        }

        public void PrintChange()
        {
            Console.WriteLine(ChangeInformer.GetChangeInfo());
        }
    }
}

