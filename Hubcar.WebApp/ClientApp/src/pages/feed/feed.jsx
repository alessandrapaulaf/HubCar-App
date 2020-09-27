import React, { useEffect, useState } from 'react';
import FeedCard from './feed-card/feed-card';
import './feed.css';
import image from '../../assets/logoHigh.png';
import mock from './feedMock';

const Feed = () => {
  var [mockFeed, setMock] = useState([]);

  useEffect(() => {
    mockFeed = mock;
    setMock(mockFeed);
  });

  function filterCar(event){
    mockFeed = mockFeed.filter(f => f.name.includes(event.target.value));
  }

  return (
    <div>
      <div className="header"><a href="/home"><img src={image} /></a> </div>
      <div className="title">Escolha o carro perfeito para você</div>
      <nav>
        <input type="text" placeholder="Modelo do Carro" onChange={filterCar}/>
        <div className="select-car-size">
          <div className="car-size">2 Pessoas</div>
          <div className="car-size selected">4 Pessoas</div>
          <div className="car-size">5 ou mais</div>
        </div>
      </nav>
      <div className="feed-container">
        {mockFeed.map((element, index) => (<FeedCard props={element} key={element.name}></FeedCard>))}
      </div>
    </div>
  );
}

export default Feed;