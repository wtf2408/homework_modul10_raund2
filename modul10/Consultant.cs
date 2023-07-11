namespace modul10
{

    class Consultant : Worker
    {
        public Consultant(string firstName, string lastName, string passport, string phoneNumber) :
            base(firstName, lastName, passport, phoneNumber)
        { }

        public override string GetPassport(bool isHidden = true)
        {
            if (isHidden)
            {
                return "Паспорт: **** ******";
            }
            return this.passport;
        }

        public override void SetPhoneNumber(string phoneNumber)
        {
            SaveChange(WorkerPosition.Consultant, this.phoneNumber ?? "none", phoneNumber);
            this.phoneNumber = phoneNumber;
        }
    }
}
