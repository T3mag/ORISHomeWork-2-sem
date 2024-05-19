import './details.css'
import TypeCard from './TypeCard';


function Moves({moveName}) {
    return (
        <>
        <div className='Moves'>
            <text>Moves</text>
            <div className='moves-container'>
                <div className="moves-list">
                    {moveName.slice(0, 3).map((move, index) => (
                        <TypeCard key={index} typeName={move.move.name} />
                    ))}  
                </div>
                <div className="moves-list">
                    {moveName.slice(3, 6).map((move, index) => (
                        <TypeCard key={index} typeName={move.move.name} />
                    ))}  
                </div>
            </div>
               
        </div>       
        </>
    );    
}

export default Moves;