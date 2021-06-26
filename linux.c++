/* Programa que leer el valor del radio y calcula la longitud de la circunferencia, el área del círculo y el volumen de la esfera correspondiente a ese radio. */

#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;
int main(void)
{
    const float PI = 3.1416;
    float radio;
    cout << "Introduce el valor del radio : ";
    cin >> radio;
    cout << "\nLongitud de la circunferencia: " << fixed << setprecision(2) << 2*PI*radio;
    cout << "\nArea del circulo: " << PI*pow(radio,2);
    cout << "\nVolumen de la esfera: " << (4.0/3)*PI*pow(radio,3) << endl;
    system("pause");
}