import React, { useState, useEffect } from 'react';
import { Modal, ModalBody, ModalHeader, Col, Input, Label,
  ModalFooter, Button, Form, FormGroup, Media } from 'reactstrap';
import Placeholder from './../../../assets/placeholder.jpg'; 

export const CreateCarro = (props) => {

  return(
    <Modal isOpen={props.modal} toggle={props.toggle} className="modal-dialog">
      <ModalHeader toggle={props.toggleModal}>Adicionar um carro</ModalHeader>
        <ModalBody>
          <Form>
            <FormGroup row>
              <Col sm={6}>
                <Label for="modelo">Modelo</Label>
                <Input type="text" name="modelo"/>
              </Col>
              <Col sm={6}>
                <Label for="placa">Placa</Label>
                <Input type="text" name="placa"/>
              </Col>
            </FormGroup>
            <FormGroup row>
              <Col sm={6}>
                <Label for="ano">Ano</Label>
                <Input type="select" name="select" id="exampleSelect">
                  <option>2020</option>
                  <option>2019</option>
                  <option>2018</option>
                  <option>2017</option>
                  <option>2016</option>
                </Input>
              </Col>
              <Col sm={6}>
                <Label for="valorDiaria">Valor da diária</Label>
                <Input type="number" name="valorDiaria"/>
              </Col>
            </FormGroup>
            <FormGroup row>
              <Col sm={6}>
                <Media left>
                  {/* TO-DO: Anexo de imagem */}
                  <Media style={{height: "150px", width:"auto"}} object src={Placeholder} alt="image" />
                </Media>
              </Col>
              <Col sm={6}>
                <Label for="foto">Foto do carro</Label>
                <Input type="file" name="foto" accept=".jpg, .jpeg, .png" />
              </Col>
            </FormGroup>  
          </Form>
        </ModalBody>
        <ModalFooter>
          <Button className="button" onClick={props.toggle}>Salvar</Button>{' '}
          <Button className="button" style={{backgroundColor: "gray", borderColor: "gray"}} onClick={props.toggle}>Cancelar</Button>
        </ModalFooter>
    </Modal>
  );
}

export default CreateCarro;