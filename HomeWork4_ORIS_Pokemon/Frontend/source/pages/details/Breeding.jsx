import './details.css'
import Moves from './Moves'
import Abilities from './Abilities';

function Breeding({ pokemonData }) {
    const meters = (pokemonData.height / 10).toFixed(1);
    const feet = Math.floor(meters / 0.3048);
    const inches = Number((meters / 0.3048 - feet).toFixed(1).toString().split('.')[1].charAt(0));
    const inchesStr = (inches < 10) ? `0${inches}` : `${inches}`;
    var feetAndInches = ''
    if (inches === 0){
        feetAndInches = `${feet}'`
    }
    else if (feet === 0){
        feetAndInches = `${inchesStr}''`
    }
    else{
        feetAndInches = `${feet}' ${inchesStr}''`
    }
    const kg = pokemonData.weight / 10; 
    const lbs = (kg * 2.20462).toFixed(1);
    const moves = pokemonData.moves.slice(0, 6)
    return (
        <>
            <div className="Breeding">
            <text className='headBreeding'>Breeding</text>

                <div className="height-weight">
                    <div className="stat">

                        <span>Height</span>
                        <div className="stat-container">
                            <span>{feetAndInches}</span>
                            <span>{meters} m</span> 
                        </div>
                    </div>
                    <div className="stat">
                        <span>Weight</span>
                        <div className="stat-container">
                            <span>{lbs} lbs</span>
                            <span>{kg} kg</span>
                        </div>
                    </div>
                </div>
            </div>       
                <Moves moveName={moves}></Moves> 
                <Abilities pokemon={pokemonData}></Abilities>
                
        </>
    );    
}


export default Breeding;