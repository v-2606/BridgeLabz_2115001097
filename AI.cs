//using System;
//using System.Collections.Generic;

//    public abstract class JobPosition
//    {
//        public string ApplicantName { get; private set; }
//        public int WorkExperience { get; private set; }

//        public JobPosition(string applicantName, int workExperience)
//        {
//            ApplicantName = applicantName;
//            WorkExperience = workExperience;
//        }

//        public abstract void ShowPositionDetails();
//    }

//    public class SoftwareDeveloper : JobPosition
//    {
//        public string TechStack { get; private set; }

//        public SoftwareDeveloper(string applicantName, int workExperience, string techStack)
//            : base(applicantName, workExperience)
//        {
//            TechStack = techStack;
//        }

//        public override void ShowPositionDetails()
//        {
//            Console.WriteLine($"[Software Developer] Applicant: {ApplicantName}, Experience: {WorkExperience} years, Technology: {TechStack}");
//        }
//    }

    
//    public class DataAnalyst : JobPosition
//    {
//        public string AnalysisTool { get; private set; }

//        public DataAnalyst(string applicantName, int workExperience, string analysisTool)
//            : base(applicantName, workExperience)
//        {
//            AnalysisTool = analysisTool;
//        }

//        public override void ShowPositionDetails()
//        {
//            Console.WriteLine($"[Data Analyst] Applicant: {ApplicantName}, Experience: {WorkExperience} years, Tool: {AnalysisTool}");
//        }
//    }

    
//    public class ResumeHandler<T> where T : JobPosition
//    {
//        private List<T> resumeCollection = new List<T>();

//        public void AddApplicantResume(T resume)
//        {
//            resumeCollection.Add(resume);
//        }

//        public void DisplayAllResumes()
//        {
//            foreach (var resume in resumeCollection)
//            {
//                resume.ShowPositionDetails();
//            }
//        }
//    }

//    public static class ResumeUtility
//    {
//        public static void EvaluateResume<T>(ResumeHandler<T> resumeHandler, T resume) where T : JobPosition
//        {
//            if (resume.WorkExperience < 1)
//            {
//                Console.WriteLine($"Warning: {resume.ApplicantName} has less than 1 year of experience.");
//            }

//            resumeHandler.AddApplicantResume(resume);
//            Console.WriteLine($"Resume added for {resume.ApplicantName}");
//        }
//    }

    
//    class AI
//    {
//        static void Main(string[] args)
//        {
           
//            ResumeHandler<SoftwareDeveloper> softwareResumes = new ResumeHandler<SoftwareDeveloper>();
//            ResumeHandler<DataAnalyst> dataResumes = new ResumeHandler<DataAnalyst>();

           
//            SoftwareDeveloper applicant1 = new SoftwareDeveloper("xyz", 5, "C#");
//            DataAnalyst applicant2 = new DataAnalyst("abc", 3, "Python");

//            ResumeUtility.EvaluateResume(softwareResumes, applicant1);
//            ResumeUtility.EvaluateResume(dataResumes, applicant2);

//            Console.WriteLine("\n Software Developer Resumes ");
//            softwareResumes.DisplayAllResumes();

//            Console.WriteLine("\n Data Analyst Resumes ");
//            dataResumes.DisplayAllResumes();
//        }
//    }


//}
