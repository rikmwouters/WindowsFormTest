namespace WindowsFormsTest
{
    public class FirstName
    {
        public int NameID { get; set; }
        public string Name { get; set; }
        public string NameString
        {
            get
            {
                return $"{NameID}. { Name }";
            }
        }
    }
}
