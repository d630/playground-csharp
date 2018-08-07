namespace Quiz.Classes
{
    /*
     * This class is for storing the corresponding sql records.
     *
     * TODO: Change naming here to Csharp's naming convention?
    */

    public class Country
    {
        public Country(string c_name, string capital_name, string c_code)
        {
            this.C_name = c_name;
            this.Capital_name = capital_name;
            this.C_code = c_code;
        }

        public string C_name { get; set; }
        public string Capital_name { get; set; }
        public string C_code { get; set; }
    }
}
