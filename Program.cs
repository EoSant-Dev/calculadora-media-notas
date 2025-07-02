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

List<char> notas = ['A', 'B', 'C', 'D', 'F'];

Console.Clear();
Console.WriteLine("Boletim escolar da turma 1-A");
Console.WriteLine("Estudantes\tNotas");


for (int i = 0; i < 4; i++)
{
    if (medias[i] >= 91 && medias[i] <= 100)
    {
        Console.WriteLine($" •{nomes[i]} \t{medias[i]}\t{notas[0]}");
    }

    else if (medias[i] >= 81 && medias[i] <= 90)
    {
        Console.WriteLine($" •{nomes[i]} \t{medias[i]}\t{notas[1]}");
    }

    else if (medias[i] >= 71 && medias[i] <= 80)
    {
        Console.WriteLine($" •{nomes[i]} \t{medias[i]}\t{notas[2]}");
    }


    else if (medias[i] >= 61 && medias[i] <= 70)
    {
        Console.WriteLine($" •{nomes[i]} \t{medias[i]}\t{notas[3]}");
    }

    else if (medias[i] < 60)
    {
        Console.WriteLine($" •{nomes[i]} \t{medias[i]}\t{notas[4]}");
    }
}