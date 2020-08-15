import React, { Component, useState } from 'react';
import Logo from './../../assets/sloganhigh.jpg'
import './styles.css';
import { InputGroup, Input } from 'reactstrap';
import Draw from './../../assets/draw.svg'

class Login extends Component {
  render(){
    return(
      <div className="content">
        <div className="logo">
          <img src={Logo}/>
        </div>
        <div className="draw">
          <img src={Draw}/>
        </div>

        <InputGroup className="input">
          <Input placeholder="Digite aqui seu email" />
        </InputGroup>
      </div>
    );
  } 
}

export default Login;
