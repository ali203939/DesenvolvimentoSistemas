using AppExercicioDipBiblioteca.Model;

//var acervo = new AcervoFisico("Clean Code", "A-14");
//var leitor = new Leitor("Carlos", "2025010", acervo);
//leitor.ExibirEmprestimo();


var acervoDigital = new AcervoDigital("Clean Code", "www.exemplo.com/cleancode");
var acervoFisico = new AcervoFisicoDIP("Clean Code", "A-20");

var leitor1 = new Leitor("Carlos", "2025010", acervoDigital);
var leitor2 = new Leitor("Ana", "2025011", acervoFisico);

leitor1.ExibirEmprestimo();
leitor2.ExibirEmprestimo();