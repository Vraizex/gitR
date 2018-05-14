// FuzzyModel.cpp:
//
#include "stdafx.h"
#include <cstdlib>
#include <cmath>
#include <iostream>

using namespace std;
double integrate(double(*f)(double), double a, double b, double Fmax) {
	// Переменные для записи координат точки:
	double x, y;
	// Количество интервалов по каждой из осей:
	int m = 10000;
	// Приращение по первой координате:
	double dx = (b - a) / m;
	// Приращение по второй координате:
	double dy = Fmax / m;
	// Переменная для подсчета внутренних точек:
	int count = 0;
	// Перебор точек на плоскости:
	for (int i = 0; i <= m; i++) {
		for (int j = 0; j <= m; j++) {
			// Первая координата точки:
			x = a + i * dx;
			// Вторая координата точки:
			y = j * dy;
			// Проверка точки:
			if (y <= f(x)) {
				// Если точка под графиком функции:
				count++;
			}
		}
	}
	// Доля внутренних точек:
	double z = (double)count / (m + 1) / (m + 1);
	// Результат функции:
	return Fmax * (b - a)*z;
}
// Подынтегральные функции:
double F1(double x) {
	return x * (1 - x);
}
double F2(double x) {
	double pi = 3.141592;
	return pi / 2 * tan(pi*x / 4);
}
// Главная функция программы:
double f(double x, double y) {
	return x * x*exp(-x) - y;
}
// Функция для решения дифференциального
// уравнения методом Рунге-Кутты:
double dsolve(double(*f)(double, double), double x0, double y0, double x) {
	// Количество интервалов:
	int n = 1000;
	// Переменные для записи промежуточных
	// значений при вычислениях:
	double p1, p2, p3, p4;
	// Приращение по аргументу:
	double h = (x - x0) / n;
	// Начальное значение искомой функции:
	double y = y0;
	// Вычисление значения функции в точке:
	for (int k = 0; k<n; k++) {
		p1 = f(x0 + k * h, y);
		p2 = f(x0 + k * h + h / 2, y + h * p1 / 2);
		p3 = f(x0 + k * h + h / 2, y + h * p2 / 2);
		p4 = f(x0 + k * h + h, y + h * p3);
		y = y + (h / 6)*(p1 + 2 * p2 + 2 * p3 + p4);
	}
	// Значение искомой функции в точке:
	return y;
}
// Функция, определяющая точное решение
// дифференциального уравнения:
double Y(double x) {
	return (x*x*x / 3 + 1)*exp(-x);
}
// Главная функция программы:


int main()
{
	// Изменение кодировки консоли:
	system("chcp 1251>nul");
	cout << "Вычисление интегралов\n";
	cout << integrate(F1, 0, 1, 0.25) << " vs. " << (double)1 / 6 << endl;
	cout << integrate(F2, 0, 1, 1.6) << " vs. " << log(2) << endl;
	// Задержка консольного окна:
	// Массив значений аргумента, для которых
	// вычисляется решение дифференциального уравнения:
	double x[] = { 0,0.5,1,3,10 };
	cout << "Решение дифференциального уравнения:\n";
	for (int k = 0; k<5; k++) {
		cout << dsolve(f, 0, 1, x[k]) << " vs. " << Y(x[k]) << endl;
	}
	// Задержка консольного окна:
	system("pause>nul");
    return 0;
}