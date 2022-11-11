System.Console.WriteLine("Начнем считать!");
string str = Console.ReadLine();

int i = 0;
char Operat = '+';
int act = 0;
 int num1=0;
  int num2=0;
  int index=0;
while (i < str.Length)
{
    if(act==0)
    {
        if(str[i]=='+' || str[i]=='-' || str[i]=='/' || str[i]=='*'){
            Operat= str[i];
            string numString1="";
            for (int j = 0; j < i; j++)
            {
                numString1+=str[j];
            }
            num1 = Convert.ToInt32(numString1);
            i++;
            act++;
            index=i;
        }
        else {
            i++;    
            }
    }
    else {
        if(str[i]!='='){
            i++;
        }
        else{
             string numString2="";
            for (int j = index; j < i; j++)
            {
                numString2+=str[j];
            }
            num2 = Convert.ToInt32(numString2);
            SolveTheEquation(num1, num2, Operat);
            return;
        }   
    }
}

void SolveTheEquation(int number1, int number2, char operation){
    int dec;
    if(operation=='+')
    {
        dec=number1+number2;
        Console.WriteLine($"ответ {dec}");
        return;
    }
    if(operation=='-')
    {
        dec=number1-number2;
        Console.WriteLine($"ответ {dec}");
        return;
    }
    if(operation=='/')
    {
        dec=number1/number2;
        Console.WriteLine($"ответ {dec}");
        return;
    }
    if(operation=='*')
    {
        dec=number1*number2;
        Console.WriteLine($"ответ {dec}");
        return;
    }
}
