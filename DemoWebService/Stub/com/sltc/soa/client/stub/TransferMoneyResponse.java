
package com.sltc.soa.client.stub;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="TransferMoneyResult" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "transferMoneyResult"
})
@XmlRootElement(name = "TransferMoneyResponse")
public class TransferMoneyResponse {

    @XmlElement(name = "TransferMoneyResult")
    protected double transferMoneyResult;

    /**
     * Gets the value of the transferMoneyResult property.
     * 
     */
    public double getTransferMoneyResult() {
        return transferMoneyResult;
    }

    /**
     * Sets the value of the transferMoneyResult property.
     * 
     */
    public void setTransferMoneyResult(double value) {
        this.transferMoneyResult = value;
    }

}
