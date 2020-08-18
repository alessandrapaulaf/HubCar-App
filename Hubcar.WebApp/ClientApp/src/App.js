import React, { Component } from 'react';
import { BrowserRouter, Route } from 'react-router-dom';
import Routes from './Routes';
import { } from 'cors';
import './custom.css'
import './App.css';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div>
        <BrowserRouter>
          <Route component={Routes} />
        </BrowserRouter>
      </div>
    );
  }
}
