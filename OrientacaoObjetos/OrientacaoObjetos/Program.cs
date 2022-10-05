using OrientacaoObjetos;

var aluno1 = new Aluno();
var materia = new Materia();

aluno1.Matricula = 1;
aluno1.Nome = "Ana Maria";
aluno1.Media = 8.2m;

var aluno2 = new Aluno(2, "Osvaldo Junior", 5.1m);

var aluno = new Aluno();
aluno.Email = "aluno@mail.com";