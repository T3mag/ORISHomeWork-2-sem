import React, { useState, useEffect } from 'react';

function PokemonCard({ pokemon }) {
  const [pokeData, setPokeData] = useState(null);
  useEffect(() => {
    fetch(pokemon)
      .then(response => response.json())
      .then(data => {
          setPokeData(data);
      })
      .catch((error) => {
          console.log('There was an ERROR: ', error);
      });
  }, [pokemon]);
  if(!pokeData){
    return(
      <div></div>
    )
  } else {
    return (
        <div className="PokemonCard">
          <h6>{pokeData.name.charAt(0).toUpperCase() + pokeData.name.slice(1)}</h6>
          <span>#{pokeData.id}</span>
          <img src={pokeData.sprites.other.home.front_default} /> 
            <div  className='types'>
            {pokeData.types.map((type, index) => <Type key={index} type={type.type.name} />)}
            </div>
  
        </div>
    ); 
  }
}
  
const Type = ({type}) => {
    return (
      <div className={type.toLowerCase()}>
        <label>{type.charAt(0).toUpperCase() + type.slice(1)}</label>
      </div>
    );
} 
  
export default PokemonCard;