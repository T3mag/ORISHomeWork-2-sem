import { Link } from "react-router-dom";
import "./details.css";
import arrow from "../../img/arrow-left.svg";
import pokeball from "../../img/PokeBall.png";

const Header = () => {
  return (
    <>
      <div className="head">
        <img src={pokeball} className="pokeball"></img>
        <Link to={`/`}>
          <img src={arrow} className="arrow"></img>
        </Link>
      </div>
    </>
  );
};

export default Header;
