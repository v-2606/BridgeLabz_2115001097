using System;
class Handshake{
  static int HandshakeCount(int student){
    	int Count= (student*(student-1))/2;
		return Count;
  }
  static void Main(String[] args)
    {
        Console.Write("Enter Number of students ");
        int student= Convert.ToInt32(Console.ReadLine());
	int result=HandshakeCount(student);
	Console.WriteLine("Possible handshake "+result);
	
}
}