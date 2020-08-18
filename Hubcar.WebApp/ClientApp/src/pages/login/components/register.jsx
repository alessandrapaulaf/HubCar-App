import React, { useEffect, useState } from 'react';
import { Button, Form, FormGroup, Input, Col, Row } from 'reactstrap';
import  InputMask from 'react-input-mask';
import './login.css';
import Api from './../../services/Api';
import axios from 'axios';
import { Alert, AlertTitle } from '@material-ui/lab';

const Register = () => {
  let [ufsIBGE, setUfsIBGE] = useState([]);
  let [cidadesIBGE, setCidadesIBGE] = useState([]);
  let [uf, setUf] = useState();
  let [values, setValues] = useState({});
  let [cpf, setCpf] = useState({});

  useEffect(() => {
    axios.get("https://servicodados.ibge.gov.br/api/v1/localidades/estados")
      .then(response => {
      const ufInitials = response.data.map(uf => uf.sigla);
      setUfsIBGE(ufInitials);
    });
  }, []);
  
  useEffect(() => {
    axios.get(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/${uf}/municipios`)
    .then(response => {
      const cidades = response.data.map(cidade => cidade.nome);
      setCidadesIBGE(cidades);
    });  
  }, [uf]);

  function handleChange(event){
    setValues({
      ...values,
      [event.target.name]: event.target.value
    });
  }

  function handleChangeUf(event){
    let uf = event.target.value;
    setValues({
      ...values,
      uf: uf
    });
    setUf(uf);
  }

  function handleChangeCity(event){
    let cidade = event.target.value;
    setValues({
      ...values,
      cidade: cidade
    });
  }

  function handleChangeCpf(event){
    let cpf = event.target.value;
    let newState = {
      mask: '999.999.999-99',
      value: cpf
    };
    setCpf(newState);
    setValues({
      ...values,
      cpf: cpf
    });
  }

  function handleSave(event){
    event.preventDefault();

    const data = {
      nome: values.nome,
      email: values.email,
      cpf: values.cpf.replice('/./g', ''),
      cidade: values.cidade,
      uf: values.uf
    }

    fetch(`/api/Usuario/Create`, {
      method: 'POST',
      body: data
    }).then((response) => {
      if (response.data.status === 200){
        return(
          <div>
          <Alert severity="success">
            <AlertTitle>Success</AlertTitle>
            This is a success alert — <strong>check it out!</strong>
          </Alert>
          </div>
        );
      }
    });
  }


  return (
    <Form>
      <FormGroup>
        <Input type="text" name="nome" onChange={handleChange} placeholder="Nome completo" />
      </FormGroup>
      <FormGroup>
        <InputMask 
          className="input" 
          nome="cpf" 
          placeholder="CPF" 
          {...cpf}
          onChange={handleChangeCpf}/>
      </FormGroup>
      <FormGroup>
        <Input type="email" name="email" id="exampleEmail" onChange={handleChange} placeholder="Email." />
      </FormGroup>
      <FormGroup>
        <Input type="password" name="senha" id="examplePassword" onChange={handleChange} placeholder="Senha" />
      </FormGroup>
      <FormGroup>
        <Row>
          <Col md={4}>
            <Input type="select" name="select" id="exampleSelect" onChange={handleChangeUf}>
              <option value="0">UF</option>
              {ufsIBGE.map(estado => (
                <option key={estado} value={estado}>{estado}</option>
              ))}
            </Input>
          </Col>
          <Col md={8}>
            <Input type="select" name="select" id="exampleSelect" onChange={handleChangeCity}>
              <option value="0">Cidade</option>
              {cidadesIBGE.map(city => (
                <option key={city} value={city}>{city}</option>
              ))}
            </Input>
          </Col>
        </Row>
      </FormGroup>
      <Button className="button" onSubmit={handleSave}>Cadastro</Button>
    </Form>
  );
}

export default Register;