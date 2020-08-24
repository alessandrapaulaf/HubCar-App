import React, { Component } from 'react';
import Home from './pages/home-page';
import Login from './pages/login/index';
import { Switch, Route, BrowserRouter } from 'react-router-dom';
import Layout from './home/Layout';
import CreateCarro from './pages/carro/create';

class Routes extends Component {
  render() {
    return (
      <div>
        <BrowserRouter>
          <Switch>
            <Route exact path='/login' component={Login} />
            <Layout>
              <Route path='/' component={Home} />
            </Layout>
          </Switch>
        </BrowserRouter>
      </div>
    );
  }
}


export default Routes;