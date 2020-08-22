import React, { useState, useEffect } from 'react';
import 'date-fns';
import DateFnsUtils from '@date-io/date-fns';
import { Card, Button, Form, FormGroup, Input, Label, Col, Row } from 'reactstrap';
import { MuiPickersUtilsProvider, KeyboardDatePicker } from '@material-ui/pickers';
import './home.css';
import { createMuiTheme } from "@material-ui/core";
import { ThemeProvider } from "@material-ui/styles";
import { red } from '@material-ui/core/colors';
import Arrow from './../../assets/seta-direita.png'

const defaultMaterialTheme = createMuiTheme({
  palette: {
    primary: red,
  },
});

const Home = () => {
  let [map, setMap] = useState({});
  let [dataRetirada, setDataRetirada] = useState(new Date());
  let [dataEntrega, setDataEntrega] = useState(new Date());

  useEffect(() => {
    var mapboxgl = require('mapbox-gl/dist/mapbox-gl.js');
    mapboxgl.accessToken = 'pk.eyJ1IjoiYWxlcGZyYW5jaXMiLCJhIjoiY2tlMGJnZ3FzMnFqNDJ1bnVrY2l0cmNjdCJ9.QmrWXa9N5sFWk0DOxkO0Aw';
    setMap(new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/streets-v11'
    }));
  }, []);

  return (
    <div className="container">
      <div className="form">
        <Card style={{padding: 0}} className="card">
          <Form>
            <FormGroup>
              <Label for="exampleEmail">Onde deseja retirar seu carro?</Label>
              <Input className="input" type="text"  placeholder="Digite seu endereço" />
            </FormGroup>
            <FormGroup>
              <ThemeProvider theme={defaultMaterialTheme}>
                <MuiPickersUtilsProvider utils={DateFnsUtils}>
                  <KeyboardDatePicker
                    disableToolbar
                    variant="inline"
                    format="dd/MM/yyyy"
                    margin="normal" 
                    id="date-picker-inline"
                    label="Data de retirada do veículo"
                    value={dataRetirada}
                    onChange={value => setDataRetirada(value)}
                    KeyboardButtonProps={{
                      'aria-label': 'change date',
                    }}
                  />
                  <KeyboardDatePicker
                    disableToolbar
                    variant="inline"
                    format="dd/MM/yyyy"
                    margin="normal" 
                    id="date-picker-inline"
                    label="Data de entrega"
                    value={dataEntrega}
                    onChange={value => setDataEntrega(value)}
                    KeyboardButtonProps={{
                      'aria-label': 'change date',
                    }}
                  />
                </MuiPickersUtilsProvider>
              </ThemeProvider>
            </FormGroup>
            <Button className="button" style={{marginTop: 15, height: "40px"}}><img src={Arrow} style={{height:"70%"}}/></Button>
          </Form>
        </Card>
      </div>
      <div id='map' style={{width: 600, height: 450}}></div>
    </div>
  );
}

export default Home;