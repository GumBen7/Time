namespace TimeSpace {
    class Program {
        static void Main(string[] args) {
            var t1 = new Time(3600);
            var t2 = new Time();
            t2.ChangeTimeByHours(1);
            Console.WriteLine(t1.GetHashCode() == t2.GetHashCode());
            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1 == t2);
        }
    }
}