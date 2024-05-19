import React from "react";
import ReactDOM from "react-dom/client";
import "./index.css";
import App from "./App";
import CardPokemon from "./pages/details/index.jsx";
import { BrowserRouter, Routes, Route } from "react-router-dom";

const root = ReactDOM.createRoot(document.getElementById("root"));
root.render(
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<App />} />
      <Route path="/details/:name" element={<CardPokemon />} />
    </Routes>
  </BrowserRouter>
);
