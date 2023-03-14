import React, { useState, useEffect } from "react";
import "./Home.css";
import { GetProducts } from "../../services/productService";

const Home = () => {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchProducts = async () => {
      const res = await GetProducts();
      console.log(res);
      setProducts(res.data);
    };

    fetchProducts();
  }, []);

  return (
    <div className="products-container">
      <h1>Products</h1>
      {products && products.length > 0 ? (
        <ul className="products-list">
          {products.map((product, index) => (
            <li key={index} className="products-list-item">
              {product}
            </li>
          ))}
        </ul>
      ) : (
        <p>No Products</p>
      )}
    </div>
  );
};

export default Home;
