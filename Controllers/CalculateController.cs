using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Task_Manager.Models;

namespace Task_Manager.Controllers
{
    public class CalculateController : Controller
    {

        [HttpGet]
            public IActionResult Calculate()
            {
                return View(new InputModel());
            }

            [HttpPost]
            public IActionResult Calculate(InputModel model)
            {
            bool ik = !string.IsNullOrEmpty(model.UserInput);
                if (!string.IsNullOrEmpty(model.UserInput))
                {
                    try
                    {
                        // Выполняем вычисление выражения
                        var result = EvaluateExpression(model.UserInput);
                        model.UserInput = result.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Если возникла ошибка, отображаем сообщение
                        model.UserInput = $"Ошибка: {ex.Message}";
                    }
                }
                else
                {
                    model.UserInput = "Введите выражение!";
                }

                return View(model);
            }

            private double EvaluateExpression(string expression)
            {
                // Используем DataTable для вычисления выражения
                var dataTable = new DataTable();
                var value = dataTable.Compute(expression, string.Empty);
                return Convert.ToDouble(value);
            }
        }
    }
