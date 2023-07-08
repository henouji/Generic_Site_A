using System;
using Microsoft.AspNetCore.Mvc;
using SiteAPI.ControllerModels;
using SiteAPI.Models;
using SiteAPI.Services.Contracts;

namespace SiteAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : Controller
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllUsers(int pageSize, int pageNumber)
		{
			return Ok(await _userService.GetAllUserAsync(pageSize, pageNumber));
		}

		[HttpGet("userId")]
		public async Task<IActionResult> GetUser(string userId)
		{
			return Ok(await _userService.GetUserAsync(userId));
		}

		[HttpPost]
		public async Task<IActionResult> CreateUser(UserRequest user)
		{
			try
			{
				await _userService.CreateUserAsync(user);
				return CreatedAtAction(nameof(GetUser), user);
			}
			catch(Exception ex)
			{
				return Json(new { result = false, error = ex.Message });
            }
		}

		[HttpPut("userId")]
		public async Task<IActionResult> UpdateUser(UserRequest user, string userId)
		{
			try
			{
				await _userService.UpdateUserAsync(user, userId);
                return NoContent();
            }
			catch(Exception ex)
			{
                return Json(new { result = false, error = ex.Message });
            }
		}

		[HttpDelete("userId")]
		public async Task<IActionResult> DeleteUser(string userId)
		{
			try
			{
				await _userService.DeleteUserAsync(userId);
			return NoContent();
			}
            catch (Exception ex)
            {
                return Json(new { result = false, error = ex.Message });
            }
        }
	}
}

