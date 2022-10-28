/*Caroline Hana
10-26-2022
MadLib, console creates a story with different inputs
Peer Review : Jessie Lamzon
Code is working well and runs without any errors.  I like how simple and well formated the code looks!  Good job!
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HanaC_MadLibEndpoint.Controllers
{
    [Route("[controller]")]
    public class MadLib : Controller
    {
        [HttpGet]
        [Route("Fill/{name}/{color}/{location}/{car}/{restaurant}/{animal}/{month}/{emotion}/{noun}/{food}")]
        public string fill(string name, string color, string location, string car, string restaurant, string animal, string month, string emotion, string noun, string food)
        {
            
           return $"{name} is a monster. Who lives in the deep {location}. I love to eat at {restaurant} and I always get {food}. I have a pet {animal}, their name is {month}. I also have a {color} {car}. I am a {emotion} {noun}.";
            
        }
    }   
}