using Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ShinRoll.DTOs;
using ShinRoll.Models;
using ShinRoll.Models.Enums;

namespace ShinRoll.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CharacterController : ControllerBase
    {

        public AppDbContextPOSTGRES _database { get; set; }

        public CharacterController(AppDbContextPOSTGRES database)
        {
            _database = database;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _database.characters.ToListAsync();

            return Ok(data);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(long Id)
        {

            var characterId = await _database.characters.FindAsync(Id);

            return Ok(characterId);
        }



        [HttpPost]
        public async Task<IActionResult> Post(CreateCharacterDTO dto)
        {

            var character = new Character (
                dto.Name,
                dto.Level,
                dto.Origin,     
                dto.FightingStyles,
                dto.Species,
                dto.SubSpecie,
                dto.Profession,
                dto.Attributes
                );
          
    


            await _database.characters.AddAsync(character);
            await _database.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("attributes/{Id}")]
        public async Task<IActionResult> UpdateAttributes(UpdateAttributeDTO dTO,long Id){

            if (dTO == null) { return BadRequest(); }


            var attributesToBeUpdated = await _database.characters.FindAsync(Id);
            if (attributesToBeUpdated == null) { return NotFound(); }


             attributesToBeUpdated.UpdateAttributes(dTO);
            

            await _database.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAllCharacter(UpdateAllDTO dto , long Id)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            var CharacterOp = await _database.characters.FindAsync(Id);
            if (CharacterOp == null)
            {
                return NotFound();
            }


            CharacterOp.UpdateCharacter(dto);

            _database.Update(CharacterOp);
            await _database.SaveChangesAsync();
            
  
                return Ok(dto);
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<IActionResult> DeleteCharacter(long Id)
        {

            var characterToBeDeleted = await _database.characters.FindAsync(Id);

            if (characterToBeDeleted == null) { return NotFound(); }

             _database.characters.Remove(characterToBeDeleted);

            await _database.SaveChangesAsync();

            return Ok();
        }
        


    }
    }
