using static System.Console;
 
Write ("Enter a number:");
 
int N = Convert.ToInt32(ReadLine());

int list = -N;
while (list<=N){
    Write($"{list}, ");
    list++;
}


