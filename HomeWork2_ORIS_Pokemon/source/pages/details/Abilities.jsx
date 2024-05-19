import './details.css';

function Abilities({ pokemon }) {
    const firstAbility = pokemon.abilities[0].ability.name.charAt(0).toUpperCase();
    const secondAbility = pokemon.abilities.length > 1 ? pokemon.abilities[1] : null;

    const secondName = secondAbility && secondAbility.ability && secondAbility.ability.name
        ? secondAbility.ability.name.charAt(0).toUpperCase()
        : '';

    return (
        <>
            <div className="Abilities">
                <text className="headAbilities">Abilities</text>
                <div className="moves-containers">
                    <div className="statisabis">
                        <div className="firstSpan">
                            <span>{firstAbility}</span>
                        </div>
                        <span>{pokemon.abilities[0].ability.name}</span>
                    </div>
                    {secondName !== '' && (
                        <div className="statisabis1">
                            <div className="secondSpan">
                                <span>{secondName}</span>
                            </div>
                            <span>{secondAbility.ability.name}</span>
                        </div>
                    )}
                </div>
            </div>
        </>
    );
}

export default Abilities;
