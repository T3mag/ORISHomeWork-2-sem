import './details.css'
import React, { useState, useEffect } from 'react';
import { useParams } from "react-router-dom";
import Header from './Header';
import Breeding from './Breeding';

function CardPokemon() {
    const [pokemonData, setPokemonData] = useState(null);
    const {name} = useParams();

    useEffect(() => {
        fetch(`https://pokeapi.co/api/v2/pokemon/${name}`)
            .then(response => response.json())
            .then(pokemonData => {
                setPokemonData(pokemonData);
            });
    }, []);
    if(!pokemonData){
        return <div></div>
    }
    else{
        return (
            <>
            <Header></Header>
            <div className='Pokemon-stats'>
                <span>#{pokemonData.id}</span>
                <h6>{pokemonData.name.charAt(0).toUpperCase() + pokemonData.name.slice(1)}</h6>
                <div className='stats'>
                    <text>HP</text>
                    <div className="main-stats">
                        <div className="hp"></div>
                        <div style={{width: pokemonData.stats[0].base_stat + 'px'}} className="hp-stat"></div>
                    </div>
                    
                    <text>Attack</text>
                    <div className="main-stats">
                        <div className="attack"></div>
                        <div style={{width: pokemonData.stats[1].base_stat + 'px'}} className="attack-stat"></div>
                    </div>

                    <text>Defense</text>
                    <div className="main-stats">
                        <div className="defense"></div>
                        <div style={{width: pokemonData.stats[2].base_stat + 'px'}} className="defense-stat"></div>
                    </div>
                    
                    <text>Speed</text>
                    <div className="main-stats">
                        <div className="speed"></div>
                        <div style={{width: pokemonData.stats[5].base_stat + 'px'}} className="speed-stat"></div>
                    </div>
                    </div>
                        <div className='forImage'>
                        <div  className='type'>
                            {pokemonData.types.map((type) => <Type type={type.type.name} />)}
                        </div>
                            <img src={pokemonData.sprites.other.home.front_default}></img>
                            
                    </div>
                    
            </div>
            <Breeding pokemonData={pokemonData}/>
            </>
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

export default CardPokemon;
