using System;
class Handshake{
  static void HandshakeCount(int student){
    	int Count= (student*(student-1))/2;
		Console.WriteLine("Possible handshake "+Count);
		Console.ReadLine();
  }
  static void Main(String[] args)
    {
        Console.Write("Enter Number of students ");
        int student= Convert.ToInt32(Console.ReadLine());
	HandshakeCount(student);
}
}