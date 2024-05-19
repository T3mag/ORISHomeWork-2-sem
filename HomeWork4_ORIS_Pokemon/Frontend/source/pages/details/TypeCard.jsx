import "./details.css";
import React, { useState, useEffect } from "react";

import bug from "../../img/Bug.png";
import dark from "../../img/Dark.png";
import dragon from "../../img/Dragon.png";
import electric from "../../img/Electric.png";
import fairy from "../../img/Fairy.png";
import fight from "../../img/Fight.png";
import fire from "../../img/Fire.png";
import flying from "../../img/Flying.png";
import ghost from "../../img/Ghost.png";
import grass from "../../img/Grass.png";
import ground from "../../img/Ground.png";
import ice from "../../img/Ice.png";
import normal from "../../img/Normal.png";
import poison from "../../img/Poison.png";
import psychic from "../../img/Psychic.png";
import rock from "../../img/Rock.png";
import steel from "../../img/Steel.png";
import water from "../../img/Water.png";

function TypeCard({ typeName }) {
  const typesImages = {
    bug: bug,
    dark: dark,
    dragon: dragon,
    electric: electric,
    fairy: fairy,
    fighting: fight,
    fire: fire,
    flying: flying,
    ghost: ghost,
    grass: grass,
    ground: ground,
    ice: ice,
    normal: normal,
    poison: poison,
    psychic: psychic,
    rock: rock,
    steel: steel,
    water: water,
  };
  const [moveType, setMoveType] = useState(null);

  useEffect(() => {
    fetch(`http://localhost:5022/api/Pokemon/ByType/${typeName}`)
      .then((response) => response.json())
      .then((moveType) => {
        setMoveType(moveType);
      });
  }, [typeName]);

  if (!moveType) {
    return <div></div>;
  } else {
    const nameSplit = moveType.name.split("-");
    const name = nameSplit
      .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
      .join(" ");
    return (
      <>
        <div className={`move ${moveType.type.name}-moves`}>
          <div className="statis">
            <img
              alt={moveType.type.name}
              src={typesImages[`${moveType.type.name}`]}
            />
            <span>{name}</span>
          </div>
        </div>
      </>
    );
  }
}

export default TypeCard;
