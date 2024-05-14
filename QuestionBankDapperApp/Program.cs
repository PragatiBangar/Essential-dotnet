

using Transflower.Assessment.WebAPI.QuestionBankAPI.Controllers;
using Transflower.TFLAssessment.dapper.Repositories;
using Transflower.TFLAssessment.Entities;
using Transflower.TFLAssessment.Repositories.Interfaces;
using Transflower.TFLAssessment.Services;
using Transflower.TFLAssessment.Services.Interfaces;

IQuestionBankRepository repo=new QuestionBankDapperRepository();
IQuestionBankService svc=new QuestionBankService(repo);
QuestionBankController controller=new QuestionBankController(svc);

// Get All Questions
// List<QuestionTitle> questions = await controller.GetAllQuestions();
// foreach(QuestionTitle question in questions){
//     Console.WriteLine(" Id="+question.Id+", Title="+question.Title);
// }


// Get particular question
// Question question=await controller.GetQuestion(2);
// Console.WriteLine(" Id="+question.Id+", Title="+question.Title+", a="+question.A+", b="+question.B+", c="+question.C+", d="+question.D+", subjectId="+question.SubjectId+", answerKey="+question.AnswerKey+", evaluationCriteriaId="+question.EvaluationCriteriaId);

// Get criteria
// string criteria=await controller.GetCriteria("ADVJAVA",1);
// Console.WriteLine(criteria);


// Get All Questions by subject
// List<SubjectQuestion> questions = await controller.GetQuestionsBySubjects(1);;
// foreach(SubjectQuestion question in questions){
//     Console.WriteLine(" QuestionId="+question.QuestionId+", Title="+question.Question+" subjectId="+question.SubjectId+", Subject="+question.Subject);
// }

// Get All Questions by test
// List<Question> questions = await controller.GetQuestions(1);
// foreach(Question question in questions){
//     Console.WriteLine(" Id="+question.Id+", Title="+question.Title+", a="+question.A+", b="+question.B+", c="+question.C+", d="+question.D+", subjectId="+question.SubjectId+", answerKey="+question.AnswerKey+", evaluationCriteriaId="+question.EvaluationCriteriaId);
// }


// Get All Questions by test
// List<QuestionDetails> questions = await controller.GetQuestionsBySubjectAndCriteria(1,2);
// foreach(QuestionDetails question in questions){
//     Console.WriteLine(" questionId="+question.Id+", subject="+question.Subject+", criteria="+question.Criteria);
// }

// Update answerkey
// bool status=await controller.UpdateAnswer(1 ,'a');
// Console.WriteLine(status);

// Update options
// Question question=new Question();
//   question.Title= "what is base";
//   question.A= "a";
//   question.B= "b";
//   question.C= "c";
//   question.D= "d";
//   question.AnswerKey= "d";
// bool status=await controller.UpdateQuestionOptions(1, question);
// Console.WriteLine(status);

// Insert answerkey
// NewQuestion question=new NewQuestion();
//   question.Title= "what is base";
//   question.A= "a";
//   question.B= "b";
//   question.C= "c";
//   question.D= "d";
//   question.AnswerKey= 'd';
//   question.SubjectId= 1;
//   question.EvaluationCriteriaId= 2;
// bool status=await controller.InsertQuestion(question);
// Console.WriteLine(status);




