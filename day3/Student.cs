using System;

public class Student
{
    public string name;
    public int studId;
    public double examFee;
    public Student(int studId,String name,double examFee)
    {
    this.studId=studId;
    this.name=name;
    this.examFee=examFee;
    }

}
public class DayScholar : Student
{
    public double transportFee;
    public DayScholar(int studId,String name,double examFee,double transportFee):base(studId,name,examFee)
    {
    
    this.transportFee=transportFee;
    }
    public void dayScholarDetails()
    {
    Console.WriteLine("Student Id: {0}",studId);
    Console.WriteLine("Student Name: {0}",name);
    Console.WriteLine("Student Exam Fee : {0}",examFee);
    Console.WriteLine("Student Transport Fee : {0}",transportFee);
    }
    public double payFee(double examFee,double transportFee,double paidFee)
    {
    double total=examFee+transportFee;
    return (total-paidFee);
    }
}
public class Hosteller :Student
{
    public double hostelFee;
    public Hosteller(int studId,String name,double examFee,double hostelFee):base(studId,name,examFee)
    {
    
    this.hostelFee=hostelFee;
    
    }
    public void hostellerDetails()
    {
    Console.WriteLine("Student Id : {0}",studId);
    Console.WriteLine("Student Name: {0}",name);
    Console.WriteLine("Student Exam Fee: {0}",examFee);
    Console.WriteLine("Student Hostel Fee: {0}",hostelFee);
    }
}
public class RunClass
{
    public static void Main(String[] args)
    {
        DayScholar ds1=new DayScholar(1,"ABC",100,200);
        DayScholar ds2=new DayScholar(2,"DEF",200,150);
        Hosteller h1=new Hosteller(3,"GHI",300,300);
        Hosteller h2=new Hosteller(4,"JKL",400,100);
        ds1.dayScholarDetails();
        double remain1=ds1.payFee(ds1.transportFee,ds1.examFee,10000);
        Console.WriteLine("The remaining amount to be paid :{0}",remain1);
        ds2.dayScholarDetails();
        double remain2=ds1.payFee(ds2.transportFee,ds2.examFee,15000);
        Console.WriteLine("The remaining amount to be paid :{0}",remain2);
        h2.hostellerDetails();
        h1.hostellerDetails();
    }
}