using AppExercicioISP.Entities;
using AppExercicioISP.Entities.interfaces;

List<IControlavel> controlavel = new List<IControlavel>();

controlavel.Add(new ArCondicionado());
controlavel.Add(new Televisao());

foreach (var item in controlavel)
{
    item.Desligar();
}