namespace modul10_1302220101
{
    public class Mahasiswa
    {
        public String Name { get; set; }
        public String Nim {  get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa(String Name, String Nim, List<String> Course, int Year)
        {
            this.Name = Name;
            this. Nim = Nim;
            this. Course = Course;
            this. Year = Year;
        }
    }
}
