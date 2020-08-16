import React, { Component, useState } from 'react';
import Logo from './../../assets/sloganhigh.jpg'
import './styles.css';
import { InputGroup, Input } from 'reactstrap';
import Draw from './../../assets/draw.svg'

class Login extends Component {
  render(){
    return(
      <div className="container">
        <div className="content">
          <div className="logo">
            <img src={Logo}/>
          </div>
          <div className="draw">
            <img src={Draw}/>
          </div>
        </div>
        <div className="input">
          <InputGroup>
            <Input placeholder="Insira seu email aqui." type="email"/>
          </InputGroup>
          <InputGroup>
            <Input placeholder="senha" type="password"/>
          </InputGroup>
        </div>
      </div>
    );
  } 
}

export default Login;
