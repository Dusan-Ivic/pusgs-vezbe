import React from "react";
import "./LogoItem.css";

const LogoItem = ({ name, image }) => {
  return (
    <div className="logo-item">
      <h1>{name}</h1>
      <img src={image} alt={name} />
    </div>
  );
};

export default LogoItem;
