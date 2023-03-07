import React from "react";
import { useParams } from "react-router-dom";
import "./LogoItem.css";
import { logos } from "../../data/logos";

const LogoItem = () => {
  const { name } = useParams();
  const image = logos.find((l) => l.name === name).image;

  return (
    <div className="logo-item">
      <h1>{name}</h1>
      <img src={image} alt={name} />
    </div>
  );
};

export default LogoItem;
