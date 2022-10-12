import React, { Component } from 'react';
import './App.css';
import Layout from '../components/Layout/Layout';
import  Chuck  from "../components/Chuck/Chuck";
import  Swapi  from "../components/Swapi/swapi";
import Home from "../components/Home/Home";
import { BrowserRouter, Switch, Route } from 'react-router-dom';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <Layout>
          <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/chuck"  component={Chuck} />
            <Route path="/swapi"  component={Swapi} />
          </Switch>
        </Layout>
      </BrowserRouter>
    );
  }
}

export default App;