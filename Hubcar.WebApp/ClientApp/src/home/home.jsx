import React, { Component } from 'react';
import Layout from './Layout';
import RoutesApp from './../RoutesApp';

export class Home extends Component {
  render() {
    return (
      <div>
        <Layout>
          <RoutesApp/>
        </Layout>
      </div>
    );
  }
}

export default Home;