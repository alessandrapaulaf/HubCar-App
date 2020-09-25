import React, { useEffect, useState } from 'react';
import FeedCard from './feed-card/feed-card';
import './feed.css';
import image from '../../assets/logoHigh.png';

const Feed = () => {
  return (
    <div>
      <div className="header"><a href="/home"><img src={image} /></a> </div>
      <div className="title">Escolha o carro perfeito para você</div>
      <nav>
        <input type="text" placeholder="Modelo do Carro" />
        <div className="select-car-size">
          <div className="car-size">2 Pessoas</div>
          <div className="car-size selected">4 Pessoas</div>
          <div className="car-size">5 ou mais</div>
        </div>
      </nav>
      <div className="feed-container">
        <FeedCard></FeedCard>
        <FeedCard></FeedCard>
        <FeedCard></FeedCard>
        <FeedCard></FeedCard>
        <FeedCard></FeedCard>
        <FeedCard></FeedCard>
      </div>
    </div>
  );
}

export default Feed;