using System.Diagnostics;
using Transflower.TFLAssessment.Entities;
using Transflower.TFLAssessment.Services.Interfaces;
//Controller is now responsible to handle HTTP Requests
namespace Transflower.Assessment.WebAPI.QuestionBankAPI.Controllers;


public class QuestionBankController 
{
    private readonly IQuestionBankService _svc;

    public QuestionBankController(IQuestionBankService service)
    { 
        _svc=service;
    }

    //http://localhost:5172/api/questionbank/questions
    public async Task<List<QuestionTitle>> GetAllQuestions()
    {
        List<QuestionTitle> questions=await _svc.GetAllQuestions();
        return questions;
    }


    //http://localhost:5172/api/questionbank/questions/2
   
    public async Task<Question> GetQuestion(int questionId)
    {
        Question question = await _svc.GetQuestion(questionId);
        return question;
    }

  
    public async Task<string> GetCriteria(string subject, int questionId)
    {
        string criteria = await _svc.GetCriteria(subject,questionId);
        return criteria;
    }


    //get questions by subject .
    //http://localhost:5172/api/questionbank/questions/subjects/2

    public async Task<List<SubjectQuestion>> GetQuestionsBySubjects(int id)
    {    
        List<SubjectQuestion> questions =await _svc.GetQuestionsBySubject(id);
        return questions;
    }


         
    //Get questions by testid .
 
    public async Task<List<Question>> GetQuestions(int testId)
    {    
        List<Question> questions =await _svc.GetQuestions(testId);
        return questions;
    }

        
        
    //Get questions by subject criteria .
    //http://localhost:5172/api/questionbank/questions/subjects/4/criterias/1

    public async Task<List<QuestionDetails>>  GetQuestionsBySubjectAndCriteria(int subjectId,int criteriaId)
    {   
        List<QuestionDetails> questions =await _svc.GetQuestionsBySubjectAndCriteria(subjectId,criteriaId);
        return questions;
    }


        
       
    //Update  answer of the question. 
   
    public async Task<bool> UpdateAnswer(int id ,char answerKey)
    {   
        bool status = await _svc.UpdateAnswer(id,answerKey);
        return status;
    }

        

    //Update question options .
    //http://localhost:5172/api/questionbank/update/options/question/1
   
    public async Task<bool> UpdateQuestionOptions(int id,Question options)
    {

        bool  status = await _svc.UpdateQuestionOptions(id,options);
        return status;
    }

    //http://localhost:5172/api/questionbank/question
   
    public async Task<bool> InsertQuestion(NewQuestion question)
    {
        bool status =await  _svc.InsertQuestion(question);
        return status;
    }
      
}
