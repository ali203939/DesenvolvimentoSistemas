using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebAPIAula1.Application.DTOs;
using WebAPIAula1.Application.UseCases.WeatherForecasts.Commands.CreateWeatherForecast;
using WebAPIAula1.Application.UseCases.WeatherForecasts.Queries.GetWeatherForecasts;

namespace WebAPIAula1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        /// <summary>
        /// Get weather forecasts for the next N days
        /// </summary>
        /// <param name="days">Number of days (default: 5, max: 30)</param>
        /// <returns>List of weather forecasts</returns>
        [HttpGet(Name = "GetWeatherForecast")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecastDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<WeatherForecastDto>>> Get([FromQuery] int days = 5)
        {
            var query = new GetWeatherForecastsQuery { Days = days };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// Create a new weather forecast
        /// </summary>
        /// <param name="command">Weather forecast data</param>
        /// <returns>Created weather forecast</returns>
        [HttpPost(Name = "CreateWeatherForecast")]
        [ProducesResponseType(typeof(WeatherForecastDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<WeatherForecastDto>> Create([FromBody] CreateWeatherForecastCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtRoute("GetWeatherForecast", new { days = 30 }, result);
        }
    }
}
