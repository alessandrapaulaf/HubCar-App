import React, { useEffect, useState } from 'react';
import './feed-card.css';

const FeedCard = () => {
  return (
    <div>
      <div className="feed-card">
        <div className="image">
          <img src="https://picsum.photos/300/200" />
        </div>
        <div className="description">
          <div className="info">
            <div className="name">Ford 2017</div>
            <div className="size">para 4 pessoas</div>
            <div className="price">R$ 30,00</div>
          </div>
          <div className="hire-button">
            <button>ALUGAR</button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default FeedCard;