using System;
class Handshake{
  static int HandshakeCount(int numberOfStudents){
    	int Count= (numberOfStudents*(numberOfStudents-1))/2;
		return Count;
  }
  static void Main(String[] args)
    {
        Console.Write("Enter Number of students ");
        int numberOfStudents= Convert.ToInt32(Console.ReadLine());
	int PossibleHandshake=HandshakeCount(numberOfStudents);
	Console.WriteLine("Possible handshake "+PossibleHandshake);
	
}
}