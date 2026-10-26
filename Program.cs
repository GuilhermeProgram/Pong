//Constantes
const int largura = 40;
const int altura = 20;
const int tamanhoRaquete = 4;
// Variaveis
int bolaY = altura / 2 ;
int bolaX  = largura / 2;
int velX = 1;
int velY = -1;
int raquete1Y = (altura - tamanhoRaquete) / 2;
int raquete2Y = (altura - tamanhoRaquete) / 2;
int pontosA = 0;
int pontosB = 0;
int contador = 0;

// Codigo

while(pontosA < 5 && pontosB < 5)
{
    //ATUALIZAR 
    bolaX = bolaX + velX;
    bolaY = bolaY + velY;

    //Mostrar
    Console.Clear();
    Console.SetCursorPosition(bolaX, bolaY);
    Console.Write("O");



    Thread.Sleep(100);
}

