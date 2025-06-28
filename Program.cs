/* 
Pequeno programa desenvolvido para estudar operações matemáticas com variáveis
*/

List<double> sofiaNotas = [93, 87, 98, 95, 100];
List<double> nicolasNotas = [80, 83, 82, 88, 85];
List<double> zahirahNotas = [84, 96, 73, 85, 79];
List<double> jeongNotas = [90, 92, 98, 100, 97];

List<string> nomes = ["Sofia", "Nicolas", "Zahirah", "Jeong"];

double sofiaMediaNotas = 0;
double nicolasMediaNotas = 0;
double zahirahMediaNotas = 0;
double jeongMediaNotas = 0;

for (int i = 0; i < 5; i++)
{
    sofiaMediaNotas += sofiaNotas[i];
    nicolasMediaNotas += nicolasNotas[i];
    zahirahMediaNotas += zahirahNotas[i];
    jeongMediaNotas += jeongNotas[i];

}

sofiaMediaNotas /= 5;
nicolasMediaNotas /= 5;
zahirahMediaNotas /= 5;
jeongMediaNotas /= 5;

List<double> medias = [sofiaMediaNotas, nicolasMediaNotas,
                        zahirahMediaNotas, jeongMediaNotas];

Console.Clear();
Console.WriteLine("Boletim escolar da turma 1-A");
Console.WriteLine("Estudantes\tNotas");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($" •{nomes[i]} \t{medias[i]}");
}