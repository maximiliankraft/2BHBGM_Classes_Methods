namespace ConsoleApplication1
{
    public class Test
    {
        private string Property;

        private string _name;

        public bool IsSecret = false;
        private string _lastName;

        public string GetSecret(string secretValue)
        {
            if (IsSecret)
            {
                return "";
            } else {
                return secretValue;
            }
        }

        public string Name
        {
            get => GetSecret(_name) ;
            set => _name = value;
        }

        public string LastName
        {
            get => GetSecret(_lastName);
            set => _lastName = value;
        }

        public void ProcessProperty()
        {
            this.Property = Property + Property;
        }
    }
}