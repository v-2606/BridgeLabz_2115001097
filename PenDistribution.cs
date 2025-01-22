using  System;

class Distribution{
	public int Pen(int pen ,int student){
	int RemainingPen=pen%student;
	
	return RemainingPen;
	}
public int Distributed(int pen ,int student){
	int DistibutedToStudents=pen/student;
	
	return DistibutedToStudents;
	}
}

class PenDistribution{
	static void Main(String[] args){
	 int pen =14;
	 int students=3;
	 
	 Distribution D_pen=new Distribution();
	 int Non_distributed=D_pen.Pen(pen,students);
	 int AmongStudents=D_pen.Distributed(pen,students);
	 
	 Console.WriteLine("The Pen Per student is " +AmongStudents +" and the remaining pen not distributed is " +Non_distributed);
	
	}

}