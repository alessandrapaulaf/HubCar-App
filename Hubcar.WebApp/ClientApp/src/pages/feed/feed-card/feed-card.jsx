import React, { useEffect, useState } from 'react';
import './feed-card.css';

const FeedCard = (props, key) => {

  function getSizeCar(size) {
    const plural = size === 1 ? 'pessoa' : 'pessoas';
    return `para ${size} ${plural}`
  }
  return (
    <div>
      <div className="feed-card">
        <div className="image">
          <img src="https://picsum.photos/300/200" />
        </div>
        <div className="description">
          <div className="info">
            <div className="name">{props.props.name}</div>
            <div className="size">{getSizeCar(props.props.size)}</div>
            <div className="price">{Intl.NumberFormat('pt-BR', {style: 'currency', currency: 'BRL' }).format(props.props.price)}</div>
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