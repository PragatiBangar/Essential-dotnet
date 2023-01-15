using System;
using System.Collections.Generic;

//Donot call us, we will call you

//HRdepartment will have Jobportal

namespace RecruitmentTest
{
    public class Resume
    {
        public string Name{get; set; }
        public string Email{get; set; }
        public string Content{get; set; }

        public override string ToString()
            {
                return "Resume [email=" +Email +",name=" + Name +",content=" +Content+"]";
            }
        
    }
    //Singleton class
    public class JobPortal
    {
        private static JobPortal portal = new JobPortal();
        public List<Resume> resumeList = new List<Resume>();
        private JobPortal(){
        }
        public static JobPortal get(){
            return portal;
        }
        public void UploadContent(string name,string email,string content){
            Resume resume = new Resume();
            resume.Name = name;
            resume.Email = email;
            resume.Content = content;
            resumeList.Add(resume);
        }
        public void triggerCampusing(){
            foreach(Resume resume in resumeList)
            {
                Console.WriteLine("sending mail to " +resume.Name+ "at" +resume.Email);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            //Don't call us ,we will call you
            JobPortal.get().UploadContent("ganesh.shinde@gmail.com","Ganesh Shinde","A Java Developer");
            JobPortal.get().UploadContent("umesh.sharma@gmail.com","Umesh Sharma","A PHP Developer");
            JobPortal.get().UploadContent("neha.bhor@gmail.com","Neha Bhor","A Microservice Developer");
            JobPortal.get().UploadContent("aditya.ubale@gmail.com","Aditya Ubale","A network engineer");
            JobPortal.get().triggerCampusing();
        }
    }

}
