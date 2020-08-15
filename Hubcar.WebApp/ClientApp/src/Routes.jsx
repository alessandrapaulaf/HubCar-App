import React, { Component } from 'react';
import Home from './home/home';
import Login from './pages/login/index';
import { Switch, Route, BrowserRouter } from 'react-router-dom';

class Routes extends Component {
  render() {
    return (
      <div>
        <BrowserRouter>
          <Switch>
            <Route exact path='/login' component={Login} />
            <Route path='/' component={Home} />
          </Switch>
        </BrowserRouter>
      </div>
    );
  }
}


export default Routes;