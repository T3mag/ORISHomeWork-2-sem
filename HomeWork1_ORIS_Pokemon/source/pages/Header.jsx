import React, { useState, useEffect } from "react";
import PokemonCard from "./PokemonCard";
import axios from "axios";
import pokeball from "../../image/PokeBall.png";
import glass from "../../image/MagnifyingGlass.png";
import pika from "../../image/Pikachu.png";

const Header = () => {
  const [pokemonData, setPokemonData] = useState([]);
  const [offset, setOffset] = useState(0);
  const [fetching, setFetching] = useState(true);
  const [allPokemon, setAllPokemon] = useState([]);
  const [searchValue, setSearchValue] = useState("");
  const [filter, setFilter] = useState(allPokemon);
  const [filterExecuted, setFilterExecuted] = useState(false);

  useEffect(() => {
    if (fetching) {
      axios
        .get(`https://pokeapi.co/api/v2/pokemon?offset=${offset}&limit=50`)
        .then((data) => {
          setPokemonData((prev) => [...prev, ...data.data.results]);
          setOffset((prev) => prev + 50);
        })
        .finally(() => setFetching(false));
    }
  }, [fetching, offset]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await axios.get(
          "https://pokeapi.co/api/v2/pokemon?limit=1300"
        );
        setAllPokemon(response.data.results);
      } catch (error) {
        console.log("There was an ERROR: ", error);
      }
    };
    fetchData();
  }, []);

  useEffect(() => {
    document.addEventListener("scroll", scrollHandler);

    return function () {
      document.removeEventListener("scroll", scrollHandler);
    };
  }, []);

  const scrollHandler = (e) => {
    if (
      e.target.documentElement.scrollHeight -
        (e.target.documentElement.scrollTop + window.innerHeight) <
      100
    ) {
      setFetching(true);
    }
  };

  useEffect(() => {
    if (searchValue === "") {
      setFilter([]);
    }
  }, [searchValue]);

  const handleSearchChange = (e) => {
    setSearchValue(e.target.value);
    setFilterExecuted(false);
  };

  const handleSearchClick = () => {
    const filterBratikov = allPokemon.filter((pokemon) =>
      pokemon.name.includes(searchValue.toLowerCase())
    );
    setFilterExecuted(true);
    setFilter(filterBratikov);
  };

  if (pokemonData.length === 0) {
    return <div></div>;
  } else {
    return (
      <>
        <div className="Header">
          <div className="search-container">
            <span>Who are you looking for?</span>
            <img src={pokeball} className="pokeball" />
            <input
              placeholder="E.g. Pikachu"
              type="text"
              value={searchValue}
              onChange={handleSearchChange}
            />
            <img src={glass} className="magnifying-glass" />
            <button
              type="button"
              className="go-button"
              onClick={handleSearchClick}
            >
              Go
            </button>
          </div>
        </div>
        <div className="Card">
          {filterExecuted && filter.length === 0 && searchValue.length > 0 ? (
            <div className="NoResult">
              <h2>Oops! Try again.</h2>
              <span>
                The Pokemon you're looking for is a unicorn. It doesn't exist in
                this list
              </span>
              <img src={pika} />
            </div>
          ) : filter.length > 0 ? (
            filter.map((pokemon, index) => (
              <PokemonCard key={index} pokemon={pokemon.url} />
            ))
          ) : (
            pokemonData.map((pokemon, index) => (
              <PokemonCard key={index} pokemon={pokemon.url} />
            ))
          )}
        </div>
      </>
    );
  }
};

export default Header;
